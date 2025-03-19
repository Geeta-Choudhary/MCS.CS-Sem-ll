import java.util.*;

public class AStarSearch {
    private int vertices;
    private int[][] adjMatrix;
    private int[] heuristics;

    public AStarSearch(int vertices) {
        this.vertices = vertices;
        adjMatrix = new int[vertices][vertices];
        heuristics = new int[vertices];
    }

    public void addEdge(int start, int end, int cost) {
        adjMatrix[start][end] = cost;
        adjMatrix[end][start] = cost;
    }

    public void inputHeuristics() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter heuristic values for each vertex:");
        for (int i = 0; i < vertices; i++) {
            System.out.print("Heuristic value for vertex " + i + ": ");
            heuristics[i] = scanner.nextInt();
        }
    }

    public void aStarSearch(int start, int destination) {
        PriorityQueue<int[]> queue = new PriorityQueue<>(Comparator.comparingInt(a -> a[1])); // {node, f}
        int[] g = new int[vertices];
        Arrays.fill(g, Integer.MAX_VALUE);
        g[start] = 0;

        int[] parent = new int[vertices];
        Arrays.fill(parent, -1);

        queue.add(new int[]{start, heuristics[start]});

        while (!queue.isEmpty()) {
            int[] current = queue.poll();
            int node = current[0];

            if (node == destination) {
                printPath(parent, start, destination);
                System.out.println("\nTotal Cost: " + g[destination]);
                return;
            }

            for (int i = 0; i < vertices; i++) {
                if (adjMatrix[node][i] > 0) { // If there is an edge
                    int tentativeG = g[node] + adjMatrix[node][i];
                    if (tentativeG < g[i]) {
                        g[i] = tentativeG;
                        parent[i] = node;
                        int f = g[i] + heuristics[i];
                        queue.add(new int[]{i, f});
                    }
                }
            }
        }
        System.out.println("No path found.");
    }

    private void printPath(int[] parent, int start, int destination) {
        if (destination == -1) return;
        printPath(parent, start, parent[destination]);
        System.out.print(destination + " ");
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter number of vertices: ");
        int vertices = scanner.nextInt();
        AStarSearch graph = new AStarSearch(vertices);

        System.out.print("Enter number of edges: ");
        int edges = scanner.nextInt();
        System.out.println("Enter the edges (start, end, cost):");
        for (int i = 0; i < edges; i++) {
            int start = scanner.nextInt();
            int end = scanner.nextInt();
            int cost = scanner.nextInt();
            graph.addEdge(start, end, cost);
        }

        graph.inputHeuristics();
        System.out.print("Enter the source vertex: ");
        int source = scanner.nextInt();
        System.out.print("Enter the destination vertex: ");
        int destination = scanner.nextInt();

        System.out.println("\nPath from " + source + " to " + destination + ":");
        graph.aStarSearch(source, destination);

        scanner.close();
    }
}


/*
 
Enter number of vertices: 5
Enter number of edges: 6
Enter the edges (start, end, cost):
0 1 2
0 2 4
1 2 1
1 3 7
2 4 3
3 4 2
Enter heuristic values for each vertex:
Heuristic value for vertex 0: 7
Heuristic value for vertex 1: 6
Heuristic value for vertex 2: 4
Heuristic value for vertex 3: 2
Heuristic value for vertex 4: 0
Enter the source vertex: 0
Enter the destination vertex: 4

Path from 0 to 4:
0 1 2 4
Total Cost: 6

 */