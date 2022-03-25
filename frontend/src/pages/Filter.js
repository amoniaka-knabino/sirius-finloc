import { Button, Switch, Tabs } from 'antd'
import { AppleOutlined, AndroidOutlined } from '@ant-design/icons'
import { useState } from 'react'
import axios from 'axios'
import { Checkbox, Divider } from 'antd'
import { List, Typography } from 'antd'

const CheckboxGroup = Checkbox.Group

const plainOptions = [
  'Шрифт Брайля',
  'Голосовое озвучивание',
  'Автоматические двери',
  'Доступность для инвалидных колясок',
  'Внешний пандус',
  'Внутренний пандус',
  'Другие',
]
const defaultCheckedList = [
  'Автоматические двери',
  'Доступность для инвалидных колясок',
]

const { TabPane } = Tabs
const instance = axios.create({
  baseURL: 'https://localhost:5001',
  withCredentials: false,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': '*',
  },
})

const Filter = () => {
  const [wifi, setWifi] = useState(true)
  const [qr, setQr] = useState(true)
  const [access24Hourse, setAccess24Hourse] = useState(true)
  const [equeue, setEqueue] = useState(true)

  const [checkedList, setCheckedList] = useState(defaultCheckedList)
  const [indeterminate, setIndeterminate] = useState(true)
  const [checkAll, setCheckAll] = useState(false)
  const [data, setData] = useState({ devices: [], branches: [] })

  const onChange = (list) => {
    setCheckedList(list)
    setIndeterminate(!!list.length && list.length < plainOptions.length)
    setCheckAll(list.length === plainOptions.length)
  }
  const onCheckAllChange = (e) => {
    setCheckedList(e.target.checked ? plainOptions : [])
    setIndeterminate(false)
    setCheckAll(e.target.checked)
  }
  const onButtonClick = () => {
    var res = axios.get('http://finloc.somnoynadno.ru/map', {
      params: { wifi: wifi },
    })
    console.log(res)
  }
  return (
    <div className="filter-container">
      <Tabs
        defaultActiveKey="1"
        tabBarExtraContent={
          <Button type="primary" onClick={onButtonClick}>
            Найти
          </Button>
        }
      >
        <TabPane
          tab={
            <span>
              <AppleOutlined />
              Общее
            </span>
          }
          key="1"
        >
          <div className="filter-tab-content">
            <List>
              <List.Item>
                <Typography.Text>WI-FI</Typography.Text>
                <Switch checked={wifi} onChange={() => setWifi(!wifi)}></Switch>
              </List.Item>
              <List.Item>
                <Typography.Text>QR</Typography.Text>
                <Switch checked={qr} onChange={() => setQr(!qr)}></Switch>
              </List.Item>
              <List.Item>
                <Typography.Text>Электронная очередь</Typography.Text>
                <Switch
                  checked={equeue}
                  onChange={() => setEqueue(!equeue)}
                ></Switch>
              </List.Item>
              <List.Item>
                <Typography.Text>Круглосуточный доступ</Typography.Text>
                <Switch
                  checked={access24Hourse}
                  onChange={() => setAccess24Hourse(!access24Hourse)}
                ></Switch>
              </List.Item>
            </List>
          </div>
        </TabPane>
        <TabPane
          tab={
            <span>
              <AndroidOutlined />
              Доступная среда
            </span>
          }
          key="2"
        >
          <>
            <Checkbox
              indeterminate={indeterminate}
              onChange={onCheckAllChange}
              checked={checkAll}
            >
              Check all
            </Checkbox>
            <Divider />
            <CheckboxGroup
              options={plainOptions}
              value={checkedList}
              onChange={onChange}
            />
          </>
        </TabPane>
        <TabPane
          tab={
            <span>
              <AndroidOutlined />
              Платежные системы
            </span>
          }
          key="3"
        >
          Tab 3
        </TabPane>
      </Tabs>
    </div>
  )
}
export default Filter
