﻿namespace Domain.Interfaces
{
    public interface IUser
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public List<IWorkSheet> WorkSheets { get; set; }
    }
}
