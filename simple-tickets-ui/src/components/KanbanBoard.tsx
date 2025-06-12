import React, { useEffect, useState } from 'react';
import { TicketApi } from '../apis/ticket/ticketApi';
import { Ticket } from '../apis/ticket/ticket';
import { BordApi } from '../apis/bord/bordApi';
import { Bord } from '../apis/bord/bord';
import { BordColumnApi } from '../apis/bordColumn/bordColumnApi';
import { BordColumn } from '../apis/bordColumn/bordColumn';
import './KanbanBoard.css';

export const KanbanBoard: React.FC = () => {
  const [bord, setBord] = useState<Bord | null>(null);
  const [columns, setColumns] = useState<BordColumn[]>([]);
  const [tickets, setTickets] = useState<Ticket[]>([]);

  useEffect(() => {
    const bordApi = new BordApi();
    const columnApi = new BordColumnApi();
    const ticketApi = new TicketApi();

    async function fetchData() {
      const bords = await bordApi.list();
      if (bords.length > 0) {
        const firstBord = bords[0];
        setBord(firstBord);
        const allColumns = await columnApi.list();
        const filtered = allColumns.filter(c => firstBord.bordColumns.includes(c.id));
        setColumns(filtered);
      }
      const ts = await ticketApi.list();
      setTickets(ts);
    }
    fetchData();
  }, []);

  const renderColumn = (column: BordColumn) => {
    const columnTickets = column.ticketIds
      .map(id => tickets.find(t => t.id === id))
      .filter((t): t is Ticket => t !== undefined);

    return (
      <div key={column.id} className="kanban-column">
        <h3>{column.title}</h3>
        {columnTickets.map(t => (
          <div key={t.id} className="kanban-ticket">
            {t.title}
          </div>
        ))}
      </div>
    );
  };

  if (!bord) {
    return <div>Loading...</div>;
  }

  return (
    <div className="kanban-board">
      <h2>{bord.title}</h2>
      <div className="kanban-columns">
        {columns.map(renderColumn)}
      </div>
    </div>
  );
};
