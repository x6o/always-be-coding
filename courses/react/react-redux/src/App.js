import React from "react";
import reduxActions from './actions'
import reducer from './reducer'

// components
import Navbar from "./components/Navbar";
import CartContainer from "./components/CartContainer";

// items
import cartItems from "./cart-items";

// redux stuff
import { createStore } from 'redux'

import { Provider } from "react-redux"

// initial store
const initialStore = {
  cart: cartItems,
  total: 150,
  amount: 2,
};

// store - aka state
const store = createStore(reducer, initialStore);

console.log(store.getState());
function App() {
  // cart setup

  return (
    <Provider store={store}>
      <Navbar />
      <CartContainer />
    </Provider>
  );
}

export default App;
