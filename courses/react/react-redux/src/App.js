import React from "react";

// components
import Navbar from "./components/Navbar";
import CartContainer from "./components/CartContainer";

// items
import cartItems from "./cart-items";

// redux stuff
import {createStore} from 'redux'

// initial store
const initialStore = {
  count: 0
};

// reducer - fn to update store
const reducer = (state, action) => {
  console.log({state, action});
  return state;
};

// store - aka state
const store = createStore(reducer, initialStore);


function App() {
  // cart setup

  return (
    <main>
      <Navbar cart={store.getState()} />
      <CartContainer cart={cartItems} />
    </main>
  );
}

export default App;
