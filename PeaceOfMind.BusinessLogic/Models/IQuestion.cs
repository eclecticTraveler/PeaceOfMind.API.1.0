﻿using System;
using System.Collections.Generic;
using PeaceOfMind.DataMovement.Dtos;

namespace PeaceOfMind.Service.Models
{
    public interface IQuestion
    {
        bool IsQuestionCompleted { get; set; }
        DateTime QuestionCompletedOn { get; set; }
        int QuestionNumber { get; set; }
        IEnumerable<IQuestionOption> WordedOptions { get; set; }
        string WordedQuestion { get; set; }
    }
}