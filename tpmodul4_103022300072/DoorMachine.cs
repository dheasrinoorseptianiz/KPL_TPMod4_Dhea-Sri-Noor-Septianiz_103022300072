using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul4_103022300072
{
    public enum DoorState {Terkunci, Terbuka}
    public enum Trigger {BukaPintu, KunciPintu}

    class Transition
    {
        public DoorState PrevState;
        public DoorState NextState;
        public Trigger Trigger;

        public Transition(DoorState prevState, DoorState nextState, Trigger trigger)
        {
            PrevState = prevState;
            NextState = nextState;
            Trigger = trigger;
        }
    }

    class DoorMachine
    {
        private static List<Transition> transitions = new List<Transition>
        {
            new Transition(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu),
            new Transition(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu)
        };

        private DoorState currentState;

        public DoorMachine()
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        private DoorState GetNextState(DoorState prevState, Trigger trigger)
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
            DoorState nextState = GetNextState(currentState, trigger);
            if (nextState != currentState)
            {
                currentState = nextState;
                Console.WriteLine(nextState == DoorState.Terkunci ? "Pintu terkunci" : "Pintu tidak terkunci");
            }
        }
    }
}