import { Button, Switch, Tabs } from 'antd'
import { useState } from 'react'
import axios from 'axios'
import { Checkbox, Divider } from 'antd'
import { List, Typography } from 'antd'
import {
  branchesData,
  devicesData,
  accessMatch,
  accessOptions,
  defaultCheckedList,
  cardMatch,
  defaultCheckedCardsList,
  cardOptions,
} from './data'
import { FaMapMarkedAlt, FaWheelchair, FaRegCreditCard } from 'react-icons/fa'

const { TabPane } = Tabs

const Filter = (props) => {
  const [wifi, setWifi] = useState(true)
  const [qr, setQr] = useState(true)
  const [access24Hourse, setAccess24Hourse] = useState(true)
  const [equeue, setEqueue] = useState(true)
  const [nfc, setNfc] = useState(true)
  const [loading, setLoading] = useState(false)

  const [checkedList, setCheckedList] = useState(defaultCheckedList)
  const [indeterminate, setIndeterminate] = useState(true)
  const [checkAll, setCheckAll] = useState(false)

  const [checkedCardsList, setCheckedCardsList] = useState(
    defaultCheckedCardsList,
  )
  const [indeterminateCards, setIndeterminateCards] = useState(true)
  const [checkAllCards, setCheckAllCards] = useState(false)

  const onChange = (list) => {
    setCheckedList(list)
    setIndeterminate(!!list.length && list.length < accessOptions.length)
    setCheckAll(list.length === accessOptions.length)
  }
  const onCheckAllChange = (e) => {
    setCheckedList(e.target.checked ? accessOptions : [])
    setIndeterminate(false)
    setCheckAll(e.target.checked)
  }
  const onCardsChange = (list) => {
    setCheckedCardsList(list)
    setIndeterminateCards(!!list.length && list.length < cardOptions.length)
    setCheckAllCards(list.length === cardOptions.length)
  }
  const onCheckAllCardsChange = (e) => {
    setCheckedCardsList(e.target.checked ? cardOptions : [])
    setIndeterminateCards(false)
    setCheckAllCards(e.target.checked)
  }
  const onButtonClick = () => {
    setLoading(true)
    axios
      .post('http://somnoynadno.ru:2012/map', {
        wifi: wifi,
        qr: qr,
        equeue: equeue,
        nfc: nfc,
        access24Hourse: access24Hourse,
        accessibilities: checkedList.map((a) => accessMatch[a]),
        cards: checkedCardsList.map((c) => cardMatch[c]),
      })
      .then((result) => {
        console.log(result.data)
        props.setData(result.data)
      })
      .catch(() =>
        props.setData({ devices: devicesData, branches: branchesData }),
      )
      .finally(() => setLoading(false))
  }
  return (
    <div className="filter-container">
      <Tabs
        defaultActiveKey="1"
        tabBarExtraContent={
          <Button type="primary" onClick={onButtonClick} loading={loading}>
            Найти
          </Button>
        }
      >
        <TabPane
          tab={
            <span>
              <FaMapMarkedAlt />
              <Typography.Text className="tab-title">Общее</Typography.Text>
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
                <Typography.Text>Оплата по QR коду</Typography.Text>
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
              <List.Item>
                <Typography.Text>NFC</Typography.Text>
                <Switch checked={nfc} onChange={() => setNfc(!nfc)}></Switch>
              </List.Item>
            </List>
          </div>
        </TabPane>
        <TabPane
          tab={
            <span>
              <FaWheelchair />
              <Typography.Text className="tab-title">
                Доступная среда
              </Typography.Text>
            </span>
          }
          key="2"
        >
          <div className="filter-tab-content">
            <Typography.Text type="secondary">
              Результаты поиска будут представлены в полном соответствии с
              выбранными параметрами
            </Typography.Text>
            <br />
            <Checkbox
              indeterminate={indeterminate}
              onChange={onCheckAllChange}
              checked={checkAll}
            >
              Выбрать все
            </Checkbox>
            <Divider />
            <Checkbox.Group
              options={accessOptions}
              value={checkedList}
              onChange={onChange}
            />
          </div>
        </TabPane>
        <TabPane
          tab={
            <span>
              <FaRegCreditCard />
              <Typography.Text className="tab-title">
                Платежные системы
              </Typography.Text>
            </span>
          }
          key="3"
        >
          <div className="filter-tab-content">
            <Typography.Text type="secondary">
              Результаты поиска будут представлены в частничном соответствии с
              выбранными параметрами
            </Typography.Text>
            <br />
            <Checkbox
              indeterminate={indeterminateCards}
              onChange={onCheckAllCardsChange}
              checked={checkAllCards}
            >
              Выбрать все
            </Checkbox>
            <Divider />
            <Checkbox.Group
              options={cardOptions}
              value={checkedCardsList}
              onChange={onCardsChange}
            />
          </div>
        </TabPane>
      </Tabs>
    </div>
  )
}
export default Filter
