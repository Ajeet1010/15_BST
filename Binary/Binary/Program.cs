namespace Binary
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("BINARY SEARCH TREE ");
            Console.WriteLine("1.BST .");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> binarySearchTree = new BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
        }
    }
}