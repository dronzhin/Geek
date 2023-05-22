package DZOOP6;

import static DZOOP6.MyFunction.prompt;

public class InputToConsole implements IInputInformation
{

    @Override
    public void inputInformation(Order order) {
        order.setClientName(prompt("Client name: "));
        order.setProduct(prompt("Product: "));
        order.setQnt(Integer.parseInt(prompt("Quantity: ")));
        order.setPrice(Integer.parseInt(prompt("Price: ")));
    }
}
