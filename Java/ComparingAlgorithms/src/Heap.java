
public class Heap {

	private int[] heap;
	private int size;
	private int maxsize;

		public Heap(int maxsize) {
	        this.maxsize = maxsize;
	        this.size = 0;
	        heap = new int[maxsize];
	    }
	    
	    public Heap(int[] array, int maxsize) {
	    	this.maxsize = maxsize;
	        this.size = array.length;
	        heap = new int[maxsize];
	        for(int i=0;i<array.length;i++)
	        	heap[i+1] = array[i];
	        buildMinHeap();
	    }
	 
	    private int parent(int pos) {
	        return pos / 2;
	    }
	 
	    private int leftChild(int pos) {
	        return (2 * pos);
	    }
	 
	    private int rightChild(int pos) {
	        return (2 * pos) + 1;
	    }
	 
	    private void swap(int fpos,int spos) {
	        int tmp;
	        tmp = heap[fpos];
	        heap[fpos] = heap[spos];
	        heap[spos] = tmp;
	    }
	 
		private void minHeapify(int pos) {
	    	int smallest;
	    	int l = leftChild(pos);
	    	int r = rightChild(pos);
	    	if(l <= size && heap[l] < heap[pos]) {
	    		smallest = l;
	    	}else {
	    		smallest = pos;
	    	}
	    	if(r <= size && heap[r] < heap[smallest]) { 
	    		smallest = r;
	    	}
	    	if (smallest != pos) {
	    		swap(pos, smallest);
	    		minHeapify(smallest);
	    	}
	    }
	    
	    public int getSize() {
	    	return this.size;
	    }
	 
		public void insert(int element) {
	    	size += 1;
	        heap[size] = element;
	        int current = size;
	        while(current > 1 && heap[current] < heap[parent(current)] ) {
	            swap(current,parent(current));
	            current = parent(current);
	        }	
	    }
	    
	    public void print() {
	    	System.out.print("[");
	        for (int i = 1; i <= size; i++ ) {
	        	if(i==size)
	        		System.out.print(heap[i]);
	        	else
	        		System.out.print(heap[i]+", ");
	        }
	        System.out.println("]");
	    }
	 
	    public void buildMinHeap() {
	    	for(int i=size/2;i>=1;i--)
	    		minHeapify(i);
	    }
	    
	    public int get(int pos) {
	    	return heap[pos];
	    }
	    
	    public void set(int pos, int element) {
	    	heap[pos] = element;
	    }
	    
	    public int remove(int pos) {
	    	int extracted = heap[pos];
	        heap[pos] = heap[size--]; 
	        minHeapify(pos);
	        return extracted;
	    }
	
	    public int[] heapSort(int expectedSize) {
	    	int [] result = new int[expectedSize];
	    	for(int i = 0; i < expectedSize; i++) {
	    		result[i] = remove(1);
	    	}
	    	return result;
	    }
	    
}
