public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        // 1. Constrói o Heap (Max-Heap)
        for (int i = n / 2 - 1; i >= 0; i--) {
            MaxHeapify(nums, n, i);
        }

        // 2. Extrai os elementos do heap um por um
        for (int i = n - 1; i > 0; i--) {
            // Move a raiz atual para o fim
            int temp = nums[0];
            nums[0] = nums[i];
            nums[i] = temp;

            // Chama o heapify no heap reduzido
            MaxHeapify(nums, i, 0);
        }

        return nums;
    }

    // Versão ITERATIVA para evitar StackOverflow e ser mais rápida
    private void MaxHeapify(int[] nums, int n, int i) {
        while (true) {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && nums[left] > nums[largest]) {
                largest = left;
            }

            if (right < n && nums[right] > nums[largest]) {
                largest = right;
            }

            if (largest != i) {
                int swap = nums[i];
                nums[i] = nums[largest];
                nums[largest] = swap;
                
                // Em vez de recursão, atualizamos o 'i' e continuamos o loop
                i = largest;
            } else {
                break;
            }
        }
    }
}
