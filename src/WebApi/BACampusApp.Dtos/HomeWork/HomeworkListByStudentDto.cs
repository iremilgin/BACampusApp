﻿using BACampusApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACampusApp.Dtos.HomeWork
{
    public class HomeworkListByStudentDto
    {
        public Guid Id { get; set; }
        public Guid HomeWorkId { get; set; }
        public Guid StudentId { get; set; }
        public string? AttachedFile { get; set; }
        public string Title { get; set; }
        public string Intructions { get; set; }
        public string ReferansFile { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SubjectId { get; set; }
        public bool IsLateTurnedIn { get; set; }
        public bool IsHasPoint { get; set; }
        public string? Description { get; set; }
        public DateTime? SubmitDate { get; set; }//Teslim tarihi
        public double? Point { get; set; }//Ödev puanı
        public HomeworkState? HomeworkState { get; set; } = Entities.Enums.HomeworkState.Assigned;//Ödev Durumu ->atandı/teslim edildi/teslim edilmedi/geç teslim edildi
    }
}
