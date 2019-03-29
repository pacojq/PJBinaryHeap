
using NUnit.Framework;
using PJDataStructures.PJBinaryHeap;

namespace PJDataStructures.Tests.PJBinaryHeap
{
    [TestFixture]
    public class Tests
    {
        
	    [Test]
	    public void TestConstructor()
	    {
		    int[] parameters = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
		    BinaryHeap<int> bh = new BinaryHeap<int>(parameters);
		
		    Assert.AreEqual("[1, 2, 4, 3, 6, 5, 8, 10, 7, 9]", bh.ToString());
	    }
	    
	    
        [Test]
        public void TestAdd()
        {
	        BinaryHeap<int> bh = new BinaryHeap<int>();
		
            bh.Add(10);
            bh.Add(9);
            bh.Add(8);
            Assert.AreEqual("[8, 10, 9]", bh.ToString());
		
            bh.Add(7);		
            Assert.AreEqual("[7, 8, 9, 10]", bh.ToString());
		
            bh.Add(6);		
            Assert.AreEqual("[6, 7, 9, 10, 8]", bh.ToString());
		
            bh.Add(5);		
            Assert.AreEqual("[5, 7, 6, 10, 8, 9]", bh.ToString());
		
            bh.Add(4);		
            Assert.AreEqual("[4, 7, 5, 10, 8, 9, 6]", bh.ToString());
        }
	
        [Test]
        public void TestPeekAndPoll() {
		
            BinaryHeap<int> bh = new BinaryHeap<int>();
		
            bh.Add(9);
            bh.Add(8);
            bh.Add(7);
            bh.Add(6);		
            bh.Add(5);		
            bh.Add(1);
            bh.Add(2);
            bh.Add(3);
            bh.Add(4);		
            Assert.AreEqual("[1, 3, 2, 4, 7, 8, 5, 9, 6]", bh.ToString());
		
            Assert.AreEqual(1, bh.Peek());
            Assert.AreEqual(1, bh.Poll());
            Assert.AreEqual("[2, 3, 5, 4, 7, 8, 6, 9]", bh.ToString());
            
            Assert.AreEqual(2, bh.Peek());
            Assert.AreEqual(2, bh.Poll());
        }
	
        [Test]
        public void TestAddAndPoll()
        {
            BinaryHeap<char> bh = new BinaryHeap<char>();
		
            bh.Add('f');
            bh.Add('g');
            bh.Add('a');
            bh.Add('z');		
            bh.Add('d');		
	
            Assert.AreEqual("[a, d, f, z, g]", bh.ToString());		
            Assert.AreEqual('a', bh.Poll());
            Assert.AreEqual("[d, g, f, z]", bh.ToString());
            Assert.AreEqual('d', bh.Peek());
        }
	
        

        
        
        
        [Test]
        public void TestSort_1()
        {
            int[] input = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            BinaryHeap<int> heap = new BinaryHeap<int>(input);

            string result = "";

            // print elements in sorted order
            while (!heap.IsEmpty) 
            {
                int x = heap.Poll();
                result += x;
            }
		 		 
            Assert.AreEqual(result, "1234567891011"); 
        }
	
        [Test]
        public void TestSort_2()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();
            heap.Add(2);
            heap.Add(5);
            heap.Add(1);
            heap.Add(9);
		 
            string result = "";

            // print elements in sorted order
            while (!heap.IsEmpty) 
            {
                int x = heap.Poll();
                result += x;
            }
		 
            Assert.AreEqual(result, "1259"); 
        }
    }
}