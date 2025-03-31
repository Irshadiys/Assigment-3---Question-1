namespace Assigment_3___Question_1
{
    public partial class Form1 : Form
    {
        public string[] arr = { "Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Amy" };
        public void HeapSort(string[] arr) // we are taken our string array first
        {
            int lenth = arr.Length;

            for (int i = lenth / 2 - 1; i >= 0; i--) // for begin we should look at last possible perent
            {
                Hepify(arr, lenth, i); // and we making hepify to look if it is bigger than left or right child 
            }
            for (int i = lenth - 1; i > 0; i--) // after that we need to check next value but i--
            {
                Swap(ref arr[0], ref arr[i]); // at this point we making swap of the biggest value in array to the last position
                Hepify(arr, i, 0); //and again hepify
            }
        }
        public void Swap(ref string a, ref string b)
        {
            string temp = a;//just swap function nothing special
            a = b;
            b = temp;
        }
        public void Hepify(string[] arr, int lenth, int root)
        {
            int largest = root; 

            int left = 2 * root + 1;//check for left child
            int right = 2 * root + 2;//check for right child

            if (left < lenth && arr[left].CompareTo(arr[largest]) > 0) largest = left;// If left child is bigger, update largest

            if (right < lenth && arr[right].CompareTo(arr[largest]) > 0) largest = right;// If right child is bigger, update largest

            if (largest != root)// If largest is not root, swap and continue heapifying
            {
                Swap(ref arr[root], ref arr[largest]);
                Hepify(arr, lenth, largest);
            }
        }

        public Form1()
        {
            InitializeComponent();
            richTextBoxSortedArray.Font = new Font("Consolas", 9);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
                if (txtSearch.Text == item) 
                    lableResult.Text = "The " + item + " on a position: " + count;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            HeapSort(arr);

            richTextBoxSortedArray.Clear();

            string namesLine = "";
            string indexLine = "";

            for (int i = 0; i < arr.Length; i++)
            {
                namesLine += arr[i].PadRight(5);
                indexLine += i.ToString().PadRight(5);
            }

            richTextBoxSortedArray.AppendText(namesLine + "\n" + indexLine);
        }

    }
}
