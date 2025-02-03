﻿using FluentMigrator;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace computers_api.Data.Migrations
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("computer")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("model").AsString(120).NotNullable()
                .WithColumn("price").AsString(120).NotNullable();
        }
    }
}
