from collections import deque

class State:
    def __init__(self, left_m, left_c, right_m, right_c, boat, parent=None):
        self.left_m = left_m  # Left Missionaries
        self.left_c = left_c  # Left Cannibals
        self.right_m = right_m  # Right Missionaries
        self.right_c = right_c  # Right Cannibals
        self.boat = boat  # Boat position (0: Left, 1: Right)
        self.parent = parent

    def is_valid(self):
        """Check if the current state is valid"""
        return (self.left_m >= 0 and self.left_c >= 0 and
                self.right_m >= 0 and self.right_c >= 0 and
                (self.left_m == 0 or self.left_m >= self.left_c) and
                (self.right_m == 0 or self.right_m >= self.right_c))

    def is_goal(self):
        """Check if goal state is reached"""
        return self.left_m == 0 and self.left_c == 0 and self.right_m == 3 and self.right_c == 3

    def __eq__(self, other):
        """Override equality check for state comparison"""
        return (self.left_m == other.left_m and self.left_c == other.left_c and
                self.right_m == other.right_m and self.right_c == other.right_c and
                self.boat == other.boat)

    def __hash__(self):
        """Hash the state to allow storing in a set"""
        return hash((self.left_m, self.left_c, self.right_m, self.right_c, self.boat))


# Possible moves: [Missionaries, Cannibals]
MOVES = [
    (1, 0),  # 1 missionary
    (0, 1),  # 1 cannibal
    (1, 1),  # 1 missionary + 1 cannibal
    (2, 0),  # 2 missionaries
    (0, 2)   # 2 cannibals
]


def bfs(initial_state):
    """Breadth-First Search to find the solution"""
    queue = deque([initial_state])
    visited = set()
    visited.add(initial_state)

    while queue:
        current_state = queue.popleft()

        if current_state.is_goal():
            print_solution(current_state)
            return

        for move in MOVES:
            next_state = get_next_state(current_state, move)
            if next_state and next_state.is_valid() and next_state not in visited:
                queue.append(next_state)
                visited.add(next_state)

    print("No solution found.")


def get_next_state(current_state, move):
    """Generate next state based on the move"""
    missionaries, cannibals = move

    if current_state.boat == 0:  # Boat on the left side
        return State(
            current_state.left_m - missionaries,
            current_state.left_c - cannibals,
            current_state.right_m + missionaries,
            current_state.right_c + cannibals,
            1,  # Move boat to the right
            current_state
        )
    else:  # Boat on the right side
        return State(
            current_state.left_m + missionaries,
            current_state.left_c + cannibals,
            current_state.right_m - missionaries,
            current_state.right_c - cannibals,
            0,  # Move boat to the left
            current_state
        )


def print_solution(goal_state):
    """Print the solution path"""
    path = []
    current = goal_state

    while current:
        path.append(current)
        current = current.parent

    path.reverse()

    for state in path:
        print(f"LM: {state.left_m}, LC: {state.left_c}, RM: {state.right_m}, RC: {state.right_c}, Boat: {'Left' if state.boat == 0 else 'Right'}")

    print("Solution Found!")


if __name__ == "__main__":
    initial_state = State(3, 3, 0, 0, 0)  # Initial state with boat on the left
    bfs(initial_state)
