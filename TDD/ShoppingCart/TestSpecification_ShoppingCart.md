# Test Specification for Supermarket Checkout

## Scenario: Calculate total price for an empty cart

### Given:
- A checkout instance.

### When:
- Scanning an empty list of items.

### Then:
- The total price should be 0.

## Scenario: Calculate total price for single items

### Given:
- A checkout instance.

### When:
1. Scanning item "A".
2. Scanning item "B".

### Then:
1. The price should be 50 for item "A", 
2. The total price should be 30 for item "B".

## Scenario: Calculate total price for multiple items with quantity discounts

### Given:
- A checkout instance.

### When:
1. Scanning items in the order "AB".

### Then:
- The total price should be 80, without considering the special offer.

## Scenario: Calculate total price for a variety of items with quantity discounts

### Given:
- A checkout instance.

### When:
- Scanning items in the order "CDBA".

### Then:
- The total price should be 115, considering the individual prices and special offers.

## Scenario: Calculate total price for multiple items with mixed quantity discounts

### Given:
- A checkout instance.

### When:
- Scanning items in the order "AAABBB".

### Then:
- The total price should be 260, considering the special offers for both items "A" and "B".

## Scenario: Calculate total price for items in random order

### Given:
- A checkout instance.

### When:
- Scanning items in the order "BBCAD".

### Then:
- The total price should be 130, recognizing the items in any order, special offer on item B.

