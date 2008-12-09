﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitCommands
{
    public class CheckoutDto
    {
        public string Name { get; set; }
        public string Result { get; set; }

        public CheckoutDto(string name)
        {
            this.Name = name;
        }
    }

    public class Checkout
    {
        public CheckoutDto Dto { get; set; }
        public Checkout(CheckoutDto dto)
        {
            this.Dto = dto;
        }

        public void Execute()
        {
            GitCommands gitCommands = new GitCommands();

            Dto.Result = gitCommands.RunCmd(Settings.GitDir + "git.exe", "checkout " + Dto.Name);
        }
    }
}
