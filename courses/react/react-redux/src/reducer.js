import reduxActions from './actions'

// reducer - fn to update store
const reducer = (state, action) => {
  if (action.type === reduxActions.CLEAR_CART) {
    return { ...state, cart: [] }
  }

  if (action.type === reduxActions.DECREASE) {
    let tempCart = []

    if (action.payload.amount === 1) {
      tempCart = state.cart.filter((item) =>
        item.id !== action.payload.id);
    }
    else {
      tempCart = state.cart.map((item) => {
        if (item.id === action.payload.id) {
          item = { ...item, amount: item.amount - 1 }
        }
        return item;
      });
    }

    return { ...state, cart: tempCart }
  }

  if (action.type === reduxActions.INCREASE) {
    let tempCart = state.cart.map((item) => {
      console.log(item)
      if (item.id === action.payload.id) {
        item = { ...item, amount: item.amount + 1 }
      }
      return item;
    });
    return { ...state, cart: tempCart }
  }

  if (action.type === reduxActions.REMOVE) {
    return {
      ...state, cart: state.cart.filter((item) =>
        item.id !== action.payload.id)
    }
  }

  if (action.type === reduxActions.GET_TOTALS) {
    let { total, amount } = state.cart.reduce((cartTotal, cartItem) => {
      const { price, amount } = cartItem;
      const itemTotal = price * amount;

      cartTotal.total += itemTotal;
      cartTotal.amount += amount;
      return cartTotal;
    },
    { total: 0, amount: 0 });
    total = parseFloat(total.toFixed(2));
    return { ...state, total, amount };
  }
  return state;

};

export default reducer;