namespace Assigment_3___Question_1
{
    public partial class Form1 : Form
    {
        public string[] arr = { "Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Amy" };
        public void HeapSort(string[] arr)
        {
            int lenth = arr.Length;

            for (int i = lenth / 2 - 1; i >= 0; i--)
            {
                Hepify(arr, lenth, i);
            }
            for (int i = lenth - 1; i > 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                Hepify(arr, i, 0);
            }
        }
        public void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public void Hepify(string[] arr, int lenth, int root)
        {
            int largest = root;

            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < lenth && arr[left].CompareTo(arr[largest]) > 0) largest = left;

            if (right < lenth && arr[right].CompareTo(arr[largest]) > 0) largest = right;

            if (largest != root)
            {
                Swap(ref arr[root], ref arr[largest]);
                Hepify(arr, lenth, largest);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }
    }
}
