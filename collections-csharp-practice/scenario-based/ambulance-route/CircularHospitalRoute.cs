using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.ambulance_route
{
    public class CircularHospitalRoute : IHospitalRoute
    {
        private UnitNode head;
        //method to add unit
        public void AddUnit(string name)
        {
            HospitalUnit unit = new HospitalUnit(name);
            UnitNode node = new UnitNode(unit);

            if (head == null)
            {
                head = node;
                head.Next = head;
                return;
            }

            UnitNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = node;
            node.Next = head;
        }
        //method to display route
        public void DisplayRoute()
        {
            if (head == null)
            {
                Console.WriteLine("No hospital units present.");
                return;
            }

            UnitNode temp = head;
            do
            {
                Console.Write($"[{temp.Data.Name} | {(temp.Data.IsAvailable ? "Available" : "Busy")}] -> ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("(Back to Start)");
        }
        //method to redirect pateint
        public void RedirectPatient()
        {
            if (head == null)
            {
                Console.WriteLine("No units available.");
                return;
            }

            UnitNode temp = head;
            do
            {
                if (temp.Data.IsAvailable)
                {
                    Console.WriteLine($"🚑 Patient redirected to {temp.Data.Name}");
                    temp.Data.ChangeStatus(false);
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("❌ All units are busy!");
        }
        //method to update availiabilty
        public void UpdateAvailability(string name, bool status)
        {
            if (head == null) return;

            UnitNode temp = head;
            do
            {
                if (temp.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Data.ChangeStatus(status);
                    Console.WriteLine("Unit status updated.");
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("Unit not found.");
        }
        //method to remove unit
        public void RemoveUnit(string name)
        {
            if (head == null) return;

            UnitNode curr = head, prev = null;

            do
            {
                if (curr.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (prev != null)
                        prev.Next = curr.Next;
                    else
                    {
                        UnitNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }

                    Console.WriteLine($"{name} removed (maintenance).");
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != head);

            Console.WriteLine("Unit not found.");
        }
    }

}
