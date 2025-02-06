import java.util.*;

public class WaterJugInteractiveByBFS {
    static class State {
        int jug5, jug4;

        State(int jug5, int jug4) {
            this.jug5 = jug5;
            this.jug4 = jug4;
        }

        @Override
        public String toString() {
            return "(" + jug5 + ", " + jug4 + ")";
        }

        @Override
        public boolean equals(Object obj) {
            if (this == obj) return true;
            if (obj == null || getClass() != obj.getClass()) return false;
            State state = (State) obj;
            return jug5 == state.jug5 && jug4 == state.jug4;
        }

        @Override
        public int hashCode() {
            return Objects.hash(jug5, jug4);
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("\n=== Water Jug Problem Menu ===");
            System.out.println("1. Solve the problem interactively");
            System.out.println("2. Exit");
            System.out.print("Enter your choice: ");
            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    interactiveSolution(scanner);
                    break;
                case 2:
                    System.out.println("Exiting...");
                    scanner.close();
                    return;
                default:
                    System.out.println("Invalid choice. Please try again.");
            }
        }
    }

    // Handles the interactive solution using BFS-generated states
    public static void interactiveSolution(Scanner scanner) {
        State initialState = new State(0, 0);
        int target = 2;
        State targetState = new State(target, 0);

        Queue<State> queue = new LinkedList<>();
        Set<State> visited = new HashSet<>();
        queue.add(initialState);
        visited.add(initialState);

        Map<State, List<State>> stateTransitions = new HashMap<>();
        Map<State, State> parentMap = new HashMap<>(); // To track the solution path

        // Perform BFS to generate all valid states and their transitions
        while (!queue.isEmpty()) {
            State current = queue.poll();
            List<State> nextStates = getNextStates(current);

            for (State next : nextStates) {
                if (!visited.contains(next)) {
                    visited.add(next);
                    queue.add(next);
                    parentMap.put(next, current); // Track the parent state
                }

                stateTransitions.computeIfAbsent(current, k -> new ArrayList<>()).add(next);
            }
        }

        System.out.println("\nInteractive Solution:");
        System.out.println("You start with both jugs empty: (0, 0).");
        System.out.println("Your goal is to measure exactly 2 liters in the 5-liter jug.");
        System.out.println("Available moves:");
        System.out.println("1. Fill 5-liter jug");
        System.out.println("2. Fill 4-liter jug");
        System.out.println("3. Empty 5-liter jug");
        System.out.println("4. Empty 4-liter jug");
        System.out.println("5. Transfer from 5-liter to 4-liter jug");
        System.out.println("6. Transfer from 4-liter to 5-liter jug");

        State currentState = initialState;
        while (true) {
            System.out.println("\nCurrent state: " + currentState);

            if (currentState.equals(targetState)) {
                System.out.println("Congratulations! You've reached the goal.");
                printSolutionPath(initialState, targetState, parentMap);
                break;
            }

            System.out.print("Enter your move (1-6): ");
            int move = scanner.nextInt();
            State nextState = makeMove(currentState, move);

            if (nextState == null) {
                System.out.println("Invalid move. Try again.");
            } else if (!stateTransitions.getOrDefault(currentState, new ArrayList<>()).contains(nextState)) {
                System.out.println("This move leads to an invalid state. Try again.");
            } else {
                currentState = nextState;
            }
        }
    }

    // Returns all possible valid states from the current state
    public static List<State> getNextStates(State current) {
        List<State> nextStates = new ArrayList<>();
        int jug5 = current.jug5;
        int jug4 = current.jug4;

        // Possible operations
        nextStates.add(new State(5, jug4)); // Fill 5-liter jug
        nextStates.add(new State(jug5, 4)); // Fill 4-liter jug
        nextStates.add(new State(0, jug4)); // Empty 5-liter jug
        nextStates.add(new State(jug5, 0)); // Empty 4-liter jug

        // Pour from 5-liter to 4-liter jug
        int pourTo4 = Math.min(jug5, 4 - jug4);
        nextStates.add(new State(jug5 - pourTo4, jug4 + pourTo4));

        // Pour from 4-liter to 5-liter jug
        int pourTo5 = Math.min(jug4, 5 - jug5);
        nextStates.add(new State(jug5 + pourTo5, jug4 - pourTo5));

        return nextStates;
    }

    // Executes the move chosen by the user
    public static State makeMove(State current, int move) {
        int jug5 = current.jug5;
        int jug4 = current.jug4;

        switch (move) {
            case 1: // Fill 5-liter jug
                return new State(5, jug4);
            case 2: // Fill 4-liter jug
                return new State(jug5, 4);
            case 3: // Empty 5-liter jug
                return new State(0, jug4);
            case 4: // Empty 4-liter jug
                return new State(jug5, 0);
            case 5: // Transfer from 5-liter to 4-liter jug
                int pourTo4 = Math.min(jug5, 4 - jug4);
                return new State(jug5 - pourTo4, jug4 + pourTo4);
            case 6: // Transfer from 4-liter to 5-liter jug
                int pourTo5 = Math.min(jug4, 5 - jug5);
                return new State(jug5 + pourTo5, jug4 - pourTo5);
            default:
                return null;
        }
    }

    // Prints the solution path from the initial state to the target state
    public static void printSolutionPath(State initialState, State targetState, Map<State, State> parentMap) {
        List<State> path = new ArrayList<>();
        State current = targetState;
        while (current != null) {
            path.add(current);
            current = parentMap.get(current);
        }
        Collections.reverse(path);
        System.out.println("Solution Path:");
        for (State state : path) {
            System.out.println(state);
        }
    }
}


