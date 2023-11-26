# Pizza-Maker-Form
A Windows Forms application developed in C#. It allows users to create custom pizza orders by selecting various options like size, crust type, and toppings. The application dynamically updates the visual representation of the pizza as well as the pricing based on the user's selections.

# Table of Contents
1. [Description](#description)
2. [Features](#features)
3. [Techniques and Efficiencies](#techniques-and-efficiencies)
4. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
5. [Usage](#usage)
6. [Contribution](#contribution)

## Features

- **Dynamic Pizza Visualization:** Utilizes PictureBox to dynamically display the pizza's appearance as toppings and sizes are chosen.
- **Custom Pricing Logic:** Implements complex pricing logic, accounting for different sizes, crust types, and combinations of toppings.
- **Custom Control Drawing:** Enhances ListBox control to display order details and uses custom drawing to include separators for better readability.
- **Efficient Image Manipulation:** Efficiently creates and manipulates images to represent pizza toppings and styles.
- **Interactive Order Management**: The application features an intuitive order management system. On the right-hand side of the interface, users can view a list of all selected orders. If an order needs to be changed or removed, users can simply hover over the order text, click on it, and they will be prompted with the option to remove it from the inventory.


## Techniques and Efficiencies

- **Image Drawing with GDI+:** Uses GDI+ for high-quality drawing of images and UI elements, ensuring a smooth and visually appealing user experience.
- **Event-Driven Updates:** Employs event-driven programming to update the UI and pricing in real-time, enhancing user interaction.
- **Optimized Data Handling:** Implements efficient methods for handling and displaying data, such as `UpdateHorizontalExtent` for ListBox content.
- **Modular Design:** Code is structured in a modular fashion, making it easy to understand, maintain, and extend.

## Getting Started

### Prerequisites

- Windows operating system.
- .NET Framework (Version [specify version]).
- Visual Studio (Recommended version [specify version]).

### Installation

1. Clone the repository: `git clone [https://github.com/danieldotwav/Pizza-Maker-Form]`.
2. Open the solution file in Visual Studio.
3. Build the solution to resolve dependencies.
4. Run the application from Visual Studio.

## Usage

1. **Select Pizza Size and Crust**: Choose from predefined sizes and crust types.
2. **Customize Toppings**: Select toppings for either half or the whole pizza.
3. **Manage Orders**: Orders are listed on the right-hand side. Hover and click on an order to remove it if needed.
4. **Checkout**: Review the grand total and complete the order.

## Contribution

Contributions to improve PizzaMakerForm are always welcome. Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes and commit (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.
