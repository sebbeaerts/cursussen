using System;


namespace snippets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default Code Snippets
            //shortcut + dubbeltab


            //#if --> Creates a #if directive and a #endif directive. location: anywhere
#if true

#endif

            //#region --> Creates a #region directive and a #endregion directive. location: anywhere
            #region MyRegion

            #endregion

            //~ --> Creates a destructor for the containing class. location: inside a class.
            ~Program()
            {

            }

            //attribute --> Creates a declaration for a class that derives from Attribute. location: Inside a namespace (including the global namespace), a class, or a struct.
            [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        sealed class MyAttribute : Attribute
        {
            // See the attribute guidelines at 
            //  http://go.microsoft.com/fwlink/?LinkId=85236
            readonly string positionalString;

            // This is a positional argument
            public MyAttribute(string positionalString)
            {
                this.positionalString = positionalString;

                // TODO: Implement code here

                throw new NotImplementedException();
            }

            public string PositionalString
            {
                get { return positionalString; }
            }

            // This is a named argument
            public int NamedInt { get; set; }

            //checked --> Creates a checked block. location: Inside a method, an indexer, a property accessor, or an event accessor.
            checked
	        {

	        }

            //class --> Creates a classs declaration. location: Inside a namespace (including the global namespace), a class, or a struct.
            class MyClass
            {

            }

            //ctor --> Creates a constructor for the containing class.	location: Inside a class.
            public MyAttribute()
            {

            }

            //cw -->    Creates a call to WriteLine. location: Inside a method, an indexer, a property accessor, or an event accessor.
            Console.WriteLine();

            //do --> 	Creates a dowhile loop. location: Inside a method, an indexer, a property accessor, or an event accessor.
            do
	        {

	        } while (true);
            
            //else --> Creates an else block. location: Inside a method, an indexer, a property accessor, or an event accessor.
            else
	        {

	        }

            //enum --> Creates an enum declaration. location: Inside a namespace (including the global namespace), a class, or a struct.
            enum MyEnum
            {

            }

            //equals --> 	Creates a method declaration that overrides the Equals method defined in the Object class. location: Inside a class or a struct.
            // override object.Equals
            public override bool Equals(object obj)
            {
                //       
                // See the full list of guidelines at
                //   http://go.microsoft.com/fwlink/?LinkID=85237  
                // and also the guidance for operator== at
                //   http://go.microsoft.com/fwlink/?LinkId=85238
                //

                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                // TODO: write your implementation of Equals() here
                throw new NotImplementedException();
                return base.Equals(obj);
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                // TODO: write your implementation of GetHashCode() here
                throw new NotImplementedException();
                return base.GetHashCode();
            }

            //exception --> 	Creates a declaration for a class that derives from an exception (Exception by default). location: Inside a namespace (including the global namespace), a class, or a struct.

            [Serializable]
            public class MyException : Exception
            {
                public MyException() { }
                public MyException(string message) : base(message) { }
                public MyException(string message, Exception inner) : base(message, inner) { }
                protected MyException(
                  System.Runtime.Serialization.SerializationInfo info,
                  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
            }

            //for --> Creates a for loop. location: Inside a method, an indexer, a property accessor, or an event accessor.
            for (int i = 0; i<length; i++)
			{

			}

            //foreach --> Creates a foreach loop. location: Inside a method, an indexer, a property accessor, or an event accessor.
            foreach (var item in collection)
	        {

	        }
            
            //forr --> Creates a for loop that decrements the loop variable after each iteration. location: 	Inside a method, an indexer, a property accessor, or an event accessor.
            for (int i = length - 1; i >= 0 ; i--)
			{

			}
            
            //if --> Creates an if block. location: 	Inside a method, an indexer, a property accessor, or an event accessor.
            if (true)
	        {

	        }
            
            //indexer -->	Creates an indexer declaration. location: Inside a class or a struct.
            public object this[int index]
            {
                get { /* return the specified index here */ }
                set { /* set the specified index to value here */ }
            }

            //interface --> 	Creates an interface declaration. location: Inside a namespace (including the global namespace), a class, or a struct.
            interface IInterface
            {

            }

            //invoke --> Creates a block that safely invokes an event. location: Inside a method, an indexer, a property accessor, or an event accessor.
            EventHandler temp = MyEvent;
            if (temp != null)
            {
            temp();


            //iterator --> Creates an iterator. location: 	Inside a class or a struct.
            public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
            {

                throw new NotImplementedException();
                yield return default(ElementType);
            }

            //iterindex --> 	Creates a "named" iterator and indexer pair by using a nested class. location: Inside a class or a struct.
            public MyViewIterator MyView
            {
                get
                {
                    return new MyViewIterator(this);
                }
            }

            public class MyViewIterator
            {
                readonly MyViewIterator outer;

                internal MyViewIterator(MyViewIterator outer)
                {
                    this.outer = outer;
                }

                // TODO: provide an appropriate implementation here
                public int Length { get { return 1; } }

                public ElementType this[int index]
                {
                    get
                    {
                        //
                        // TODO: implement indexer here
                        //
                        // you have full access to MyViewIterator privates
                        //

                        throw new NotImplementedException();
                        return default(ElementType);
                    }
                }

                public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        yield return this[i];
                    }
                }
            }
        }

            //lock --> 	Creates a lock block. location: Inside a method, an indexer, a property accessor, or an event accessor.
            lock (this)
            {

            }

            //mbox --> Creates a call to MessageBox.Show. You may have to add a reference to System.Windows.Forms.dll. location: Inside a method, an indexer, a property accessor, or an event accessor.

            }
        }
    
}
