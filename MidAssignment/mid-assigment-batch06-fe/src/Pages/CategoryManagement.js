import { Table } from 'antd';
import React from 'react';
import { Link } from 'react-router-dom';

const columns = [
    {
        title: 'Category Id',
        dataIndex: 'categoryId',
        width: 150,
    },
    {
        title: 'Category Name',
        dataIndex: 'categoryName',
        width: 150,
    },
    {
        title: 'Deleted',
        dataIndex: 'isDeleted',
    },
    {
        title: 'Action',
        render: () => {
            return <>
                <button className='btn btn-warning mr-2'>Edit</button>
                <button className='btn btn-danger'>Delete</button>
            </>
        }
    },
];
const data = [];
for (let i = 0; i < 100; i++) {
    data.push({
        key: i,
        name: `Edward King ${i}`,
        age: 32,
        address: `London, Park Lane no. ${i}`,
    });
}

function CategoryManagement() {

    return (
        <div>
            <h1>Category management</h1>
            <button className='btn btn-success mb-5'><Link to="addCat">Add Category</Link></button>
            <Table
                columns={columns}
                dataSource={data}
                pagination={false}
                scroll={{
                    y: 240,
                    x:1300
                }}
            />
        </div>
    );
};

export default CategoryManagement;
