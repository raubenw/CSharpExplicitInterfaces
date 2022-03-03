using System;
using System.Collections.Generic;

namespace CSharpExplicitInterfaces {

    interface Interface1 {
        void SomeMethod();
    }

    interface Interface2 {
        void SomeMethod();
    }

    class TestInterfaces : Interface1, Interface2 {

        public void SomeMethod() {
            Console.WriteLine("This is the class SomeMethod");
        }

        void Interface1.SomeMethod() {
            Console.WriteLine("This is Interface 1 SomeMethod");
        }

        void Interface2.SomeMethod() {
            Console.WriteLine("This is Interface 2 SomeMethod");
        }
    } // End class TestInterfaces

    class Program {

        static void Main(string[] args) {

            TestInterfaces tf = new TestInterfaces();
            tf.SomeMethod();

            Interface1 intf1 = tf as Interface1;
            intf1.SomeMethod();

            Interface2 intf2 = tf as Interface2;
            intf2.SomeMethod();

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

        }
    }
}