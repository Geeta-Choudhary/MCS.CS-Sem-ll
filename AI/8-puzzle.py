import copy

# Goal state
GOAL_STATE = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 0]
]


# Display the puzzle
def display_puzzle(state):
    for row in state:
        print(row)
    print()


# Find position of empty space (0)
def find_blank(state):
    for i in range(3):
        for j in range(3):
            if state[i][j] == 0:
                return i, j
    return -1, -1


# Check if move is valid
def is_valid_move(x, y):
    return 0 <= x < 3 and 0 <= y < 3


# Apply move and return new state
def apply_move(state, move):
    x, y = find_blank(state)

    # Possible moves
    moves = {
        1: (x - 1, y),  # Up
        2: (x + 1, y),  # Down
        3: (x, y - 1),  # Left
        4: (x, y + 1)  # Right
    }

    if move in moves:
        new_x, new_y = moves[move]
        if is_valid_move(new_x, new_y):
            new_state = copy.deepcopy(state)
            # Swap blank with the adjacent number
            new_state[x][y], new_state[new_x][new_y] = new_state[new_x][new_y], new_state[x][y]
            return new_state
        else:
            print("❌ Invalid move! Try again.")
            return state
    else:
        print("❌ Invalid choice! Enter 1, 2, 3, or 4.")
        return state


# Check if the current state is the goal state
def is_goal(state):
    return state == GOAL_STATE


# Menu to take user input and move the puzzle
def main():
    # Initial state (can be modified as needed)
    initial_state = [
        [1, 2, 3],
        [4, 0, 5],
        [6, 7, 8]
    ]

    print("🎯 Goal State to Achieve:")
    display_puzzle(GOAL_STATE)

    print("🧩 Initial State:")
    display_puzzle(initial_state)

    while True:
        print("Choose your move:")
        print("1. Move Up")
        print("2. Move Down")
        print("3. Move Left")
        print("4. Move Right")
        print("5. Exit")

        try:
            choice = int(input("Enter your choice: "))

            if choice == 5:
                print("👋 Exiting... Goodbye!")
                break

            initial_state = apply_move(initial_state, choice)
            display_puzzle(initial_state)

            if is_goal(initial_state):
                print("🎉 Congratulations! You reached the goal state!")
                break

        except ValueError:
            print("❗ Please enter a valid number!")


# Run the program
if __name__ == "__main__":
    main()

