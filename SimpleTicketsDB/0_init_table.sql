SET timezone TO 'Asia/Tokyo';

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE TABLE users (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    name VARCHAR(100) NOT NULL,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE project (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    name VARCHAR(100) NOT NULL,
    description TEXT NOT NULL,
    managers UUID[] NOT NULL,
    members UUID[] NOT NULL,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE bord (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    project_id UUID REFERENCES project (id),
    title VARCHAR(100) NOT NULL,
    description TEXT NOT NULL,
    bord_columns UUID[] NOT NULL,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE bord_column (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    project_id UUID REFERENCES project (id),
    title VARCHAR(100) NOT NULL,
    ticket_ids UUID[] NOT NULL,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE status (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    project_id UUID REFERENCES project (id),
    label TEXT NOT NULL,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE ticket (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    project_id UUID REFERENCES project (id),
    column_id UUID REFERENCES bord_column (id),
    title VARCHAR(100) NOT NULL,
    description TEXT NOT NULL,
    status UUID REFERENCES status (id),
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);