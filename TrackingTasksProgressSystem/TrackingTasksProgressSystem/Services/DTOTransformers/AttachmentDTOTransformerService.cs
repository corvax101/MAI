﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingTasksProgressSystem.Services.DTOTransformers.Abstract;
using TrackingTasksProgressSystem.Models;
using TrackingTasksProgressSystem.DTO;
using TrackingTasksProgressSystem.Models.Abstract;

namespace TrackingTasksProgressSystem.Services.DTOTransformers
{
    public class AttachmentDTOTransformerService : IDtoTranformerService<BaseAttachment, AttachmentDTO>
    {
        BaseAttachment IDtoTranformerService<BaseAttachment, AttachmentDTO>.FromDto(AttachmentDTO dto)
        {
            return new Attachment(dto.Name, dto.Data, DateTime.Now);
        }


        AttachmentDTO IReadOnlyDtoTranformerService<BaseAttachment, AttachmentDTO>.ToDto(BaseAttachment attachment)
        {
            return new AttachmentDTO
            {
                Id = attachment.Id,
                Name = attachment.Name,
                Data = attachment.Data,
                CreatedAt = attachment.CreatedAt
            };
        }
    }
}
