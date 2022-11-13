import { Button, Checkbox, Form, Input } from 'antd';
import React from 'react';
import { Link } from 'react-router-dom';

const AddBook = () => {
    const onFinish = (values) => {
        console.log('Received values of form: ', values);
    };

    return (
        <div className='p-5' style={{
            width: '500px',
            margin: '0 auto',
            
        }}>
            <h3 className='text-center'>Add Book</h3>
            <Form
                name="normal_login"
                className="login-form"
                onFinish={onFinish}
            >
                <Form.Item
                    name="bookName"
                    rules={[
                        {
                            required: true,
                            message: 'Please input book name!',
                        },
                    ]}
                >
                    <Input placeholder="Book name" />
                </Form.Item>
                <Form.Item
                    name="bookName"
                    rules={[
                        {
                            required: true,
                            message: 'Please input book name!',
                        },
                    ]}
                >
                    <Input placeholder="Book name" />
                </Form.Item>
                <Form.Item>
                    
                        <Button type="primary" htmlType="submit" className="login-form-button" block>
                            Submit
                        </Button>
                    
                </Form.Item>
            </Form>
        </div>
    )
}

export default AddBook;
