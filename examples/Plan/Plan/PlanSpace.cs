using Hiperspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiLang.Pipeline.Visitor;

namespace Plan
{
    public partial class PlanSpace
    {
        protected static Horizon[] _read =
        [
            new Horizon<Project>(i => i.Deleted == false),
            new Horizon<Tasks.Task>(p => p.Deleted == false),
            new Horizon<Tasks.TaskResource>(p => p.Deleted == false),

            new Horizon<Project>(i => i.Valid == true),
            new Horizon<Tasks.Task>(p => p.Valid == true),
            new Horizon<Tasks.TaskResource>(p => p.Valid == true),
            new Horizon<Booking.Timesheet>(p => p.Valid == true),
        ];
        protected static Horizon[] _write =
        [
            new Horizon<Project>(i => i.Valid == true),
            new Horizon<Tasks.Task>(p => p.Valid == true),
            new Horizon<Tasks.TaskResource>(p => p.Valid == true),
            new Horizon<Booking.Timesheet>(p => p.Valid == true),
        ];
        private static Horizon[] _financeonly =
        [
            new Horizon<Tasks.Actual>(p => p.Approval?.Contains("Finance") == true)
        ];
        protected static Horizon[] _finance =
            _read.Union(_financeonly).ToArray();

        public override Horizon[]? Horizon { get => base.Horizon == null ? _read : _read.Union(base.Horizon).ToArray(); init => base.Horizon = value; }

        public PlanSpace(HiperSpace space, bool write = true, DateTime? AsAt = null, DateTime? DeltaFrom = null) 
            : this(space, null, AsAt, DeltaFrom)
        {
            ContextLabel = write ? "write" : "read";
        }
    }
}
