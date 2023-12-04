namespace Domain
{
    /// <summary>
    /// Domain Space with constrains applied to entities 
    /// </summary>
    /// <remarks>
    /// Hiperspace does not enforce constraints to avoid the need for a seperate 
    /// schema to handle validation failures.
    /// Using this space for population will prevent invalid data being loaded.
    /// Using a base space for loading, and constrained space for read will 
    /// filter any invalid data
    /// </remarks>
    public class tpcc : DomainSpace
    {
        private static Horizon[] _constraints =
        [
            new Horizon<tpc.tpcc.customer> (c => c.constraint == true),
            new Horizon<tpc.tpcc.district> (c => c.constraint == true),
            new Horizon<tpc.tpcc.history> (c => c.constraint == true),
            new Horizon<tpc.tpcc.item> (c => c.constraint == true),
            new Horizon<tpc.tpcc.new_order> (c => c.constraint == true),
            new Horizon<tpc.tpcc.new_order> (c => c.constraint == true),
            new Horizon<tpc.tpcc.order> (c => c.constraint == true),
            new Horizon<tpc.tpcc.warehouse> (c => c.constraint == true)
        ];

        public tpcc(HiperSpace space, DateTime? AsAt = null) : base(space, _constraints, AsAt) { }
    }
}
