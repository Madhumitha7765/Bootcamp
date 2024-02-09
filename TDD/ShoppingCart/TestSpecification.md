# Checkout System Test Specification

## Pricing Table

The pricing table for items in the supermarket checkout system:

| Item | Price | Offer (if applicable)  |
|------|-------|------------------------|
| 'A'  | 50    | 3 for 130              |
| 'B'  | 30    | 2 for 45               |
| 'C'  | 20    |                        |
| 'D'  | 15    |                        |



## Test Cases:

### Test Case 1: Empty Cart
- **Given**: An empty cart.
- **When**: Calculating the total price.
- **Then**: The total price should be 0.

### Test Case 2: Single Item Pricing
- **Given**: A cart with a single item 'A'.
- **When**: Calculating the total price.
- **Then**: The total price should be 50.

### Test Case 3: Multiple Items without Discount
- **Given**: A cart with items 'A' and 'B'.
- **When**: Calculating the total price.
- **Then**: The total price should be 80.

### Test Case 4: Mixed Items
- **Given**: A cart with items 'C', 'D', 'B', and 'A'.
- **When**: Calculating the total price.
- **Then**: The total price should be 115.

### Test Case 5: Multiple Items with Discounts
- **Given**: A cart with items 'A', 'B', 'A', 'C', 'A', and 'D'.
- **When**: Calculating the total price.
- **Then**: The system should recognize the discounts for 3 'A's (130) and not for 2 B as count<2 and calculate the total price as 195.

### Test Case 6: Various Combinations of Discounts
- **Given**: A cart with items in various combinations that satisfy discount criteria (e.g., 3 'A's, 2 'B's, etc.).
- **When**: Calculating the total price.
- **Then**: The system should regulate the cost based on the applicable discounts for each item combination. The total price should reflect the correct discounted amounts.
