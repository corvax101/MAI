﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingTasksProgressSystem.DTO.Abstract;
using TrackingTasksProgressSystem.Models;
using TrackingTasksProgressSystem.Models.Abstract;

namespace TrackingTasksProgressSystem.DTO
{
    public class EmployeeDTO : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PositionDTO Position { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Можно ли передавать c сервера Dto, содержащую пароль? (На сервер можно (при создании сотрудника))
    }
}