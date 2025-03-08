using System;

namespace tpModul4_103022300088
{
    public class DoorMachine
    {
        public enum DoorState { TERKUNCI, TERBUKA };
        public enum Trigger { KUNCI_PINTU, BUKA_PINTU };

        public class Transition
        {
            public DoorState PrevState { get; }
            public DoorState NextState { get; }
            public Trigger Trigger { get; }

            public Transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                PrevState = prevState;
                NextState = nextState;
                Trigger = trigger;
            }
        }

        private Transition[] transitions =
        {
            new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKA_PINTU),
            new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
            new Transition(DoorState.TERKUNCI, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
            new Transition(DoorState.TERBUKA, DoorState.TERBUKA, Trigger.BUKA_PINTU),
        };

        public DoorState CurrentState { get; private set; } = DoorState.TERKUNCI;

        public DoorState GetNextState(DoorState prevState, Trigger trigger)
        {
            foreach (var transition in transitions)
            {
                if (transition.PrevState == prevState && transition.Trigger == trigger)
                {
                    return transition.NextState;
                }
            }
            return prevState;
        }

        public void ActivateTrigger(Trigger trigger)
        {
            CurrentState = GetNextState(CurrentState, trigger);
        }
    }
}
