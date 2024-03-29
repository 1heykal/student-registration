﻿using SchoolManagement.Models;
using System.Collections.Generic;

namespace SchoolManagement.BLL
{
    public interface IStudent
    {
        public Student GetByID(string Id);


        public List<Student> GetAll();


        public Student Add(Student student);


        public Student Edit(Student student);


        public void Delete(string id);

    }
}
