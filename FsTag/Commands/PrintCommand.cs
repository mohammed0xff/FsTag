﻿using System.Text.RegularExpressions;

using CommandDotNet;

using FsTag.Common;
using FsTag.Filters;
using FsTag.Helpers;

namespace FsTag;

public partial class Program
{
    [Command("print", Description = "Print files that are currently tagged (in the index).")]
    [Subcommand]
    public class PrintCommand
    {
        [DefaultCommand]
        public int Execute(
            [Option('d', "delimiter", Description = "Delimiter between index items.")] string delimiter = ";")
        {
            return ExceptionWrapper.TryExecute(() =>
            {
                foreach (var item in AppData.EnumerateIndex())
                {
                    WriteFormatter.PlainNoLine(item + delimiter);
                }

                WriteFormatter.NewLine();
            });
        }
    }
}