using System;

namespace challenges.DataStructures {
    public class Heap<T> where T : IComparable<T> {
        private T[] _elements;
        private int _capacity;
        private int _size;
        public Heap(int capacity = 5) {
            _capacity = capacity;
            _elements = new T[capacity];
            _size = 0;
        }
        #region Public Interface
        public void Add(T item) {
            ensureCapacity();
            _elements[_size] = item;
            heapifyUp();
            _size++;
        }
        public T Peek() {
            if (Empty())
                throw new InvalidOperationException("Cannot peek. Heap is empty.");
            return _elements[0];
        }
        public T Poll() {
            if (Empty())
                throw new InvalidOperationException("Cannot poll. Heap is empty.");
            T item = _elements[0];
            _elements[0] = _elements[_size - 1];
            heapifyDown();
            _size--;
            return item;
        }
        public T[] ShowHeap() {
            return _elements;
        }
        public bool Empty() {
            return _size == 0;
        }
        public int Size() {
            return _size;
        }
        #endregion
        #region Helper Methods
        private void ensureCapacity() {
            if (_size == _capacity) {
                T[] elementsCopy = new T[2 * _capacity];
                Array.Copy(_elements, elementsCopy, _size);
                _elements = elementsCopy;
                _capacity = 2 * _capacity;
            }
        }
        private void swap(int index1, int index2) {
            T temp = _elements[index1];
            _elements[index1] = _elements[index2];
            _elements[index2] = temp;
        }
        private bool hasParent(int index) {
            return (index - 1)/2 >= 0;
        }
        private bool hasLeftChild(int index) {
            return 2 * index + 1 < _size;
        }
        private bool hasRightChild(int index) {
            return 2 * index + 2 < _size;
        }
        private int getLeftChildIndex(int parent) {
            return 2 * parent + 1;
        }
        private int getRightChildIndex(int parent) {
            return 2 * parent + 2;
        }
        private int getParentIndex(int childIndex) {
            return (childIndex - 1)/2;
        }
        private void heapifyUp() {
            int index = _size;
            while (hasParent(index) && _elements[index].CompareTo(getParent(index)) > 0) {
                int parentIndex = getParentIndex(index);
                swap(index, parentIndex);
                index = parentIndex;
            }
        }
        private void heapifyDown() {
            int index = 0;
            while (hasLeftChild(index)) {
                int largestChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && getRightChild(index).CompareTo(getLeftChild(index)) > 0) {
                    largestChildIndex = getRightChildIndex(index);
                }
                if (_elements[index].CompareTo(_elements[largestChildIndex]) > 0) {
                    break;
                } 
                else {
                    swap(index, largestChildIndex);
                }
                index = largestChildIndex;
            }
        }
        private T getParent(int childIndex) {
            int parentIndex = getParentIndex(childIndex);
            return _elements[parentIndex];
        }
        private T getLeftChild(int parentIndex) {
            int leftChildIndex = getLeftChildIndex(parentIndex);
            return _elements[leftChildIndex];
        }
        private T getRightChild(int parentIndex) {
            int rightChildIndex = getRightChildIndex(parentIndex);
            return _elements[rightChildIndex];
        }
        #endregion
    }
}
