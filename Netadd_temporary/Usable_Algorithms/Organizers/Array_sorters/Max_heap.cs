public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        // 1. Construir o Max-Heap (reorganizar o array)
        // Começamos do último nó que tem filhos (n/2 - 1) até a raiz
        for (int i = n / 2 - 1; i >= 0; i--) {
            Heapify(nums, n, i);
        }

        // 2. Extrair elementos um por um do heap
        for (int i = n - 1; i > 0; i--) {
            // Move a raiz atual (maior elemento) para o fim do array
            int temp = nums[0];
            nums[0] = nums[i];
            nums[i] = temp;

            // Chama Heapify na árvore reduzida para manter a propriedade de Max-Heap
            Heapify(nums, i, 0);
        }

        return nums;
    }

    // Função para manter a propriedade de Max-Heap
    private void Heapify(int[] nums, int n, int i) {
        int largest = i;    // Inicializa o maior como a raiz
        int left = 2 * i + 1;  // Filho à esquerda
        int right = 2 * i + 2; // Filho à direita

        // Se o filho da esquerda for maior que a raiz
        if (left < n && nums[left] > nums[largest]) {
            largest = left;
        }

        // Se o filho da direita for maior que o maior atual
        if (right < n && nums[right] > nums[largest]) {
            largest = right;
        }

        // Se o maior não for a raiz, troca e continua ajustando
        if (largest != i) {
            int swap = nums[i];
            nums[i] = nums[largest];
            nums[largest] = swap;

            // Recursivamente ajusta a sub-árvore afetada
            Heapify(nums, n, largest);
        }
    }
}
