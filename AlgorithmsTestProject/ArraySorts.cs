namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            int n = array.Length;  
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }      
        }

        public static void MySort2(int[] array)
        {
            int n = array.Length;  
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }    
        }

        public static void MergeSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }
        }

        public static void HeapSort(int[] array)
        {
            int n = array.Length;
    int temp;
    for(int i = n/2; i >= 0; i--) {
      heapify(array, n-1, i);
    }
    for(int i = n - 1; i >= 0; i--) {
      //swap last element of the max-heap with the first element
      temp = array[i];
      array[i] = array[0];
      array[0] = temp;

      //exclude the last element from the heap and rebuild the heap 
      heapify(array, i-1, 0);
    }
    static void heapify(int[] Array, int n, int i) {
    int max = i;
    int left = 2*i + 1;
    int right = 2*i + 2;

    //if the left element is greater than root
    if(left <= n && Array[left] > Array[max]) {
      max = left;
    }

    //if the right element is greater than root
    if(right <= n && Array[right] > Array[max]) {
      max = right;
    }

    //if the max is not i
    if(max != i) {
      int temp = Array[i];
      Array[i] = Array[max];
      Array[max] = temp;
      //Recursively heapify the affected sub-tree
      heapify(Array, n, max); 
    }
  }
  }

        public static void BubbleSort(int[] array)
        {
           int length = array.Length;

            int temp;

         for (int i = 0; i < length; i++)
            {
             for (int j = i+1; j < length; j++)
                {   
                if (array[i] > array[j])
                {
                temp = array[i];

                array[i] = array[j];

                array[j] = temp;
                }
                }
            }   
        }

        public static void ShuffleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j];
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }
        }
        public static void IntroSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }
        }

        public static void CocktailSort(int[] array)
        {
           {
        bool isSwapped = true;
        int start = 0;
        int end = array.Length;

        while (isSwapped == true)
        {

            //Reset this flag.  
            //It is possible for this to be true from a prior iteration.
            isSwapped = false;

            //Do a bubble sort on this array, from low to high. 
            //If something changed, make isSwapped true.
            for (int i = start; i < end - 1; ++i)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    isSwapped = true;
                }
            }

            //If no swaps are made, the array is sorted.
            if (isSwapped == false)
                break;

            //We need to reset the isSwapped flag for the high-to-low pass
            isSwapped = false;

            //The item we just moved is in its rightful place, 
            //so we no longer need to consider it unsorted.
            end = end - 1;

            //Now we bubble sort from high to low
            for (int i = end - 1; i >= start; i--)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    isSwapped = true;
                }
            }

            //Finally, we need to increase the starting point 
            //for the next low-to-high pass.
            start = start + 1;
        }
    }
}

        public static void QuickSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1; 
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key;  
            }
        }

        public static void BlockSort(int[] array)
        {
           int n = array.Length;
            for (int i = 1; i < n; ++i) 
            { 
                int key = array[i]; 
                int j = i - 1;
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j];
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }
        }

        public static void BogoSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i) 
            {
                int key = array[i]; 
                int j = i - 1;
  
                while (j >= 0 && array[j] > key) 
                { 
                    array[j + 1] = array[j];
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            }
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }
    }
}
