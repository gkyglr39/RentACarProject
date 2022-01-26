﻿using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Concrete
{
   public class OperationClaim:IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
