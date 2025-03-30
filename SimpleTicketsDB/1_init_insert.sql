INSERT INTO users (id, name) VALUES ('550e8400-e29b-41d4-a716-446655440000', 'systemmaster');
INSERT INTO users (name) VALUES ('user001');
INSERT INTO users (name) VALUES ('user002');
INSERT INTO users (name) VALUES ('user003');

INSERT INTO project (id, name, description, managers, members) VALUES
(
    '550e8400-e29b-41d4-a716-446655440001', 'Test Project', 'This is a test project', 
    ARRAY['550e8400-e29b-41d4-a716-446655440000']::uuid[], 
    ARRAY['550e8400-e29b-41d4-a716-446655440000']::uuid[]
);

INSERT INTO bord_column (id, project_id, title, position) VALUES
    ('550e8400-e29b-41d4-a716-446655440002', '550e8400-e29b-41d4-a716-446655440001', 'ToDo', 0);
INSERT INTO bord_column (id, project_id, title, position) VALUES
    ('550e8400-e29b-41d4-a716-446655440003', '550e8400-e29b-41d4-a716-446655440001', 'Done', 1);

INSERT INTO status (id, project_id, label) VALUES
    ('550e8400-e29b-41d4-a716-446655440004', '550e8400-e29b-41d4-a716-446655440001', 'Open');
INSERT INTO status (id, project_id, label) VALUES
    ('550e8400-e29b-41d4-a716-446655440005', '550e8400-e29b-41d4-a716-446655440001', 'Close');

INSERT INTO bord (id, project_id, title, description, bord_columns) VALUES
(
    '550e8400-e29b-41d4-a716-446655440006',
    '550e8400-e29b-41d4-a716-446655440001',
    'Test Board', 
    'This is a test board', 
    ARRAY['550e8400-e29b-41d4-a716-446655440002', '550e8400-e29b-41d4-a716-446655440003']::uuid[]
);

INSERT INTO ticket (id, project_id, column_id, position, title, description, status) VALUES
(
    '550e8400-e29b-41d4-a716-446655440010',
    '550e8400-e29b-41d4-a716-446655440001', 
    '550e8400-e29b-41d4-a716-446655440002',
    1,
    'Test Ticket', 
    'This is a test ticket',
    '550e8400-e29b-41d4-a716-446655440004'
);