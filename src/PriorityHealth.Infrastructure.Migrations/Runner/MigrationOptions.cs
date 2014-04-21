﻿using FluentMigrator;

namespace Infrastructure.Migrations.Runner
{
    public class MigrationOptions : IMigrationProcessorOptions
    {
        public bool PreviewOnly { get; set; }
        public int Timeout { get; set; }


        public string ProviderSwitches
        {
            get { return string.Empty; }
        }
    }
}
