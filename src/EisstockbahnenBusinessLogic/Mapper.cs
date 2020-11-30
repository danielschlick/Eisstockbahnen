using EisstockbahnenDatabase.Entities;
using EisstockbahnenWebModel;

namespace EisstockbahnenBusinessLogic
{
    public static class Mapper
    {
        public static UnitModel ToUnitModel(Unit unit)
        {
            if (unit == null)
            {
                return null;
            }

            return new UnitModel
            {
                Id = unit.Id,
                Name = unit.Name
            };
        }
    }
}
