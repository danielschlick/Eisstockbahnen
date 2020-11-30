using EisstockbahnenDatabase;
using EisstockbahnenDatabase.Entities;
using EisstockbahnenWebModel;
using System.Collections.Generic;

namespace EisstockbahnenBusinessLogic
{
    public class UnitService
    {
        private readonly DatabaseContext context;

        public UnitService(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(string name)
        {
            Unit unit = new Unit();
            unit.Name = name;

            context.Units.Add(unit);
            context.SaveChanges();
        }

        public IEnumerable<UnitModel> Get()
        {
            List<UnitModel> units = new List<UnitModel>();
            foreach (Unit unit in context.Units)
            {
                units.Add(new UnitModel
                {
                    Id = unit.Id,
                    Name = unit.Name
                });
            }

            return units;
        }
    }
}
