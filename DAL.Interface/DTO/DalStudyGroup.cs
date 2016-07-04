using System.Collections.Generic;

namespace DAL.Interface.DTO
{
    public class DalStudyGroup : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
