import React from 'react';
import logo from './logo.svg';
import './App.css';
import { TicketApi } from './apis/ticket/ticketApi';

function App() {
  const api = new TicketApi();
  api.list().then(tickets => {
    console.log(tickets[0]);
  });

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
