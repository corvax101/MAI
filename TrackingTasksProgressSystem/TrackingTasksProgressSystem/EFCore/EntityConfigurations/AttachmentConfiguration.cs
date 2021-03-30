﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackingTasksProgressSystem.Models;
using TrackingTasksProgressSystem.Models.Abstract;
using TrackingTasksProgressSystem.EFCore.EntityConfigurations.Abstract;

namespace TrackingTasksProgressSystem.EFCore.EntityConfigurations
{
    public class AttachmentConfiguration : BaseAttachmentConfiguration<Attachment>, IEntityTypeConfiguration<Attachment>
    {
        void IEntityTypeConfiguration<Attachment>.Configure(EntityTypeBuilder<Attachment> builder)
        {
            Configure(builder);
        }


        private protected override void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.ToTable("Attachments");
            base.Configure(builder);
        }
    }
}
