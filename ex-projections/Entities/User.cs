using ex_projections.Entities.ValueObjects;

namespace ex_projections.Entities
{
    public class User : BaseEntity<uint>
    {
        public string Name { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public int Code { get; set; }
        public string PersonalData1 { get; set; }
        public string PersonalData2 { get; set; }
        public string PersonalData3 { get; set; }
    }
}
