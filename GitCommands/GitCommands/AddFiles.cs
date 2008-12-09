﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitCommands
{
    public class AddFilesDto
    {
        public string Filter { get; set; }
        public string Result { get; set; }

        public AddFilesDto(string filter)
        {
            this.Filter = filter;
        }
    }

    public class AddFiles
    {
        public AddFilesDto Dto { get; set; }
        public AddFiles(AddFilesDto dto)
        {
            this.Dto = dto;
        }

        public void Execute()
        {
            GitCommands gitCommands = new GitCommands();

            Dto.Result = gitCommands.RunCmd(Settings.GitDir + "git.exe", "add " +  Dto.Filter);

            if (string.IsNullOrEmpty(Dto.Result))
            {
                Dto.Result = "Done";
            }
            else
            {
                Dto.Result = "Output:\n" + Dto.Result;
            }
        }
    }
}
