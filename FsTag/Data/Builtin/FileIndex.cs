﻿using FsTag.Data.Interfaces;
using FsTag.Helpers;

namespace FsTag.Data.Builtin;

public class FileIndex : IFileIndex
{
    public IEnumerable<string> EnumerateItems()
    {
        using var reader = new StreamReader(BuiltinPaths.IndexFilePath);

        while (reader.ReadLine() is {} line)
        {
            yield return line;
        }
    }

    public void Add(IEnumerable<string> items)
    {
        var itemsSet = items.ToHashSet();

        // Ensure there's no duplicates
        foreach (var item in EnumerateItems())
        {
            if (itemsSet.Remove(item))
            {
                WriteFormatter.Info($"'{item}' already exists in the tag index.");
            }
        }

        using var writer = new StreamWriter(BuiltinPaths.IndexFilePath, append: true);
        
        // By this point, all items in `set` will be unique
        foreach (var item in itemsSet)
        {
            if (!File.Exists(item))
            {
                WriteFormatter.Warning($"The file '{item}' does not exist.");
            
                continue;
            }
            
            if (!Program.DryRun)
                writer.WriteLine(item);
            
            WriteFormatter.Info($"Added '{item}' to the tag index.");
        }
        
        if (!Program.DryRun)
            writer.Flush();
    }

    public void Remove(IEnumerable<string> items)
    {
        var itemsSet = items.ToHashSet();
        
        var tempIndex = Path.GetTempFileName();
        var removedAny = false;

        using (var reader = new StreamReader(BuiltinPaths.IndexFilePath))
        {
            using var tempStream = File.OpenWrite(tempIndex);
            using var writer = new StreamWriter(tempStream);

            while (reader.ReadLine() is {} line)
            {
                if (itemsSet.Contains(line))
                {
                    WriteFormatter.Info($"Removing '{line}' from the index.");
                    removedAny = true;
                }
                else
                {
                    if (!Program.DryRun)
                        writer.WriteLine(line);
                }
            }
            
            if (!Program.DryRun)
                writer.Flush();
        }

        if (!removedAny)
        {
            WriteFormatter.Info("Nothing to remove. Terminating early.");
            
            return;
        }

        if (!Program.DryRun)
        {
            File.Delete(BuiltinPaths.IndexFilePath);
            File.Move(tempIndex, BuiltinPaths.IndexFilePath);
        }
    }

    public void Clean()
    {
        var removed = EnumerateItems().Where(tag => !File.Exists(tag));
        
        Remove(removed);
    }

    public void Clear()
    {
        if (!Program.DryRun)
            File.WriteAllText(BuiltinPaths.IndexFilePath, string.Empty);
        
        WriteFormatter.Info("Successfully cleared tag index.");
    }
}