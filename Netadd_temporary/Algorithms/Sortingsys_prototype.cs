public class MyHashSet {
    // Definimos um número primo para o tamanho para reduzir colisões
    private readonly int _numBuckets = 7919;
    private List<int>[] _buckets;

    public MyHashSet() {
        _buckets = new List<int>[_numBuckets];
    }
    
    // Função de Hash simples para decidir em qual "balde" a chave entra
    private int _hash(int key) {
        return key % _numBuckets;
    }

    public void Add(int key) {
        int index = _hash(key);
        if (_buckets[index] == null) {
            _buckets[index] = new List<int>();
        }
        
        // Só adicionamos se a chave ainda não existir
        if (!_buckets[index].Contains(key)) {
            _buckets[index].Add(key);
        }
    }
    
    public void Remove(int key) {
        int index = _hash(key);
        if (_buckets[index] != null) {
            _buckets[index].Remove(key);
        }
    }
    
    public bool Contains(int key) {
        int index = _hash(key);
        return _buckets[index] != null && _buckets[index].Contains(key);
    }
}