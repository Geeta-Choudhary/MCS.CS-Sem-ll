import heapq


class AStarSearch:
    def __init__(self, vertices):
        self.vertices = vertices
        self.adj_matrix = [[0 for _ in range(vertices)] for _ in range(vertices)]
        self.heuristics = [0] * vertices

    # Add an edge to the graph
    def add_edge(self, start, end, cost):
        self.adj_matrix[start][end] = cost
        self.adj_matrix[end][start] = cost

    # Input heuristic values
    def input_heuristics(self):
        print("Enter heuristic values for each vertex:")
        for i in range(self.vertices):
            self.heuristics[i] = int(input(f"Heuristic value for vertex {i}: "))

    # A* Search Algorithm
    def a_star_search(self, start, destination):
        # Priority queue to store (f, node)
        queue = []
        heapq.heappush(queue, (self.heuristics[start], start))

        # Cost from start to each node
        g = [float('inf')] * self.vertices
        g[start] = 0

        # Parent array to store the path
        parent = [-1] * self.vertices

        while queue:
            f, node = heapq.heappop(queue)

            # Check if we reached the destination
            if node == destination:
                self.print_path(parent, start, destination)
                print(f"\nTotal Cost: {g[destination]}")
                return

            # Explore neighbors
            for i in range(self.vertices):
                if self.adj_matrix[node][i] > 0:  # Edge exists
                    tentative_g = g[node] + self.adj_matrix[node][i]
                    if tentative_g < g[i]:
                        g[i] = tentative_g
                        parent[i] = node
                        f = g[i] + self.heuristics[i]
                        heapq.heappush(queue, (f, i))

        print("No path found.")

    # Print the path from source to destination
    def print_path(self, parent, start, destination):
        if destination == -1:
            return
        path = []
        while destination != -1:
            path.append(destination)
            destination = parent[destination]
        path.reverse()
        print(" ".join(map(str, path)))


# Main Function
if __name__ == "__main__":
    vertices = int(input("Enter number of vertices: "))
    graph = AStarSearch(vertices)

    edges = int(input("Enter number of edges: "))
    print("Enter the edges (start, end, cost):")
    for _ in range(edges):
        start, end, cost = map(int, input().split())
        graph.add_edge(start, end, cost)

    graph.input_heuristics()

    source = int(input("Enter the source vertex: "))
    destination = int(input("Enter the destination vertex: "))

    print(f"\nPath from {source} to {destination}:")
    graph.a_star_search(source, destination)
