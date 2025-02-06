import java.util.*;

class WaterJugInteractive {
    static class State {
        int x, y;

        public State(int x, int y) {
            this.x = x;
            this.y = y;
        }

        @Override
        public String toString() {
            return "(" + x + ", " + y + ")";
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int jug1Capacity = 5; // Capacity of the 5-liter jug
        int jug2Capacity = 4; // Capacity of the 4-liter jug
        int target = 2;       // Target amount of water in jug1

        State currentState = new State(0, 0);

        System.out.println("Water Jug Problem");
        System.out.println("Goal: Measure exactly " + target + " liters in the 5-liter jug.");
        System.out.println("You can choose one of the 12 actions to transition to the next state.\n");

        while (true) {
            System.out.println("Current state: " + currentState);
            if (currentState.x == target) {
                System.out.println("Congratulations! You reached the goal state.");
                break;
            }

            System.out.println("Choose your next action:");
            System.out.println("1. Fill 5-liter jug.");
            System.out.println("2. Fill 4-liter jug.");
            System.out.println("3. Empty 5-liter jug.");
            System.out.println("4. Empty 4-liter jug.");
            System.out.println("5. Transfer water from 5-liter to 4-liter jug.");
            System.out.println("6. Transfer water from 4-liter to 5-liter jug.");
            System.out.println("7. Transfer some water from 5-liter to 4-liter jug until one is full.");
            System.out.println("8. Transfer some water from 4-liter to 5-liter jug until one is full.");
            System.out.println("9. Empty both jugs.");
            System.out.println("10. Fill both jugs.");
            System.out.println("11. Empty one jug completely and fill the other.");
            System.out.println("12. Exit.");

            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    currentState = new State(jug1Capacity, currentState.y);
                    break;
                case 2:
                    currentState = new State(currentState.x, jug2Capacity);
                    break;
                case 3:
                    currentState = new State(0, currentState.y);
                    break;
                case 4:
                    currentState = new State(currentState.x, 0);
                    break;
                case 5:
                    int transferTo4 = Math.min(currentState.x, jug2Capacity - currentState.y);
                    currentState = new State(currentState.x - transferTo4, currentState.y + transferTo4);
                    break;
                case 6:
                    int transferTo5 = Math.min(currentState.y, jug1Capacity - currentState.x);
                    currentState = new State(currentState.x + transferTo5, currentState.y - transferTo5);
                    break;
                case 7:
                    if (currentState.x > 0 && currentState.y < jug2Capacity) {
                        int transfer7 = Math.min(currentState.x, jug2Capacity - currentState.y);
                        currentState = new State(currentState.x - transfer7, currentState.y + transfer7);
                    }
                    break;
                case 8:
                    if (currentState.y > 0 && currentState.x < jug1Capacity) {
                        int transfer8 = Math.min(currentState.y, jug1Capacity - currentState.x);
                        currentState = new State(currentState.x + transfer8, currentState.y - transfer8);
                    }
                    break;
                case 9:
                    currentState = new State(0, 0);
                    break;
                case 10:
                    currentState = new State(jug1Capacity, jug2Capacity);
                    break;
                case 11:
                    if (currentState.x > 0) {
                        currentState = new State(0, jug2Capacity);
                    } else if (currentState.y > 0) {
                        currentState = new State(jug1Capacity, 0);
                    }
                    break;
                case 12:
                    System.out.println("Exiting...");
                    return;
                default:
                    System.out.println("Invalid choice. Please choose a valid option.");
            }
        }

        scanner.close();
    }
}
