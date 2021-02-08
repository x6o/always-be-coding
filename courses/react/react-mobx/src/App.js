import React from 'react'
import { useLocalStore, useObserver } from 'mobx-react'

// Define React context
const StoreContext = React.createContext();

// Wrap around all the components with the provider,
// standard React behavior.
const StoreProvider = ({ children }) => {
  /*
    Store to store state inside
    Has both state properties (data we are tracking/observing)
    and functions that modify those state properties
  */
  const store = useLocalStore(() => ({
    todoList: ["Buy milk"],
    addItem: item => {
      // State in MobX is mutable, it will automatically keep
      // track of changes
      store.todoList.push(item);
    },
    get itemCount() {
      // Because it's a getter, we don't have to call the function
      // we can access it as a property.
      return store.todoList.length;
    }
  }));

  return <StoreContext.Provider value={store}>{children}</StoreContext.Provider>
}

const TodoList = () => {
  // get context using react hook
  const store = React.useContext(StoreContext);

  // Receives a function that returns the HTML to render from the component.
  return useObserver(() => (
    <ul>
      {
        store.todoList.map(item => <li key={item}>{item}</li>)
      }
    </ul>
  ))
}

const TodoForm = () => {
  // get context using react hook
  const store = React.useContext(StoreContext);
  // We can still use react state, we don't have to use mobx for everything
  const [todoItem, setTodoItem] = React.useState("");

  return (
    <form onSubmit={e => {
      store.addItem(todoItem);
      setTodoItem("");
      e.preventDefault();
    }
    }>
      <input type="text" value={todoItem} onChange={e => setTodoItem(e.target.value)} />
      <button type="submit">Add</button>
    </form>
  )
}

const BugsHeader = () => {
  const store = React.useContext(StoreContext);
  
  return useObserver(() => (
    <p>You have <b>{store.itemCount}</b> items to do:</p>
  ))
}

export default function App() {
  return (
    <StoreProvider>
      <main>
        Yet another TODO app!
        <BugsHeader />
        <TodoList />
        <TodoForm />
      </main>
    </StoreProvider>
  )
}