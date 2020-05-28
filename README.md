# Coca-Cola-popular-drink

## Description

This repository is a Software of Console with C# etc.

## Installation

Using CSharp preferably.

## Development

Using MonoDevelop.

## Usage

```html
$ git clone https://github.com/DanielArturoAlejoAlvarez/Coca-Cola-popular-drink[NAME APP]

$ npm install 

```

Follow the following steps and you're good to go! Important:

![alt text](https://sailleshpawar.files.wordpress.com/2017/02/7.gif)

## Coding

### Config

```cs
...
public class VendingMachine
    {
        public List<CocaColaProduct> Products { get; set; }
        public string Payment { get; set; }

        public VendingMachine()
        {
            this.Products = new List<CocaColaProduct>();
            CocaColaProduct cocaCola = new CocaColaProduct();
            //categories: popular,diet,cool
            cocaCola.Code = "P-123";
            cocaCola.Name = "Coca-Cola";
            cocaCola.Category = "POPULAR";
            cocaCola.QTY = 500;
            cocaCola.Price = 5.25;

            CocaColaProduct dietCoke = new CocaColaProduct();
            dietCoke.Code = "D-456";
            dietCoke.Name = "Diet Coke";
            dietCoke.Category = "DIET";
            dietCoke.QTY = 250;
            dietCoke.Price = 6.75;

            CocaColaProduct sprite = new CocaColaProduct();
            sprite.Code = "D-789";
            sprite.Name = "Sprite";
            sprite.Category = "COOL";
            sprite.QTY = 150;
            sprite.Price = 7.55;

            this.Products.Add(cocaCola);
            this.Products.Add(dietCoke);
            this.Products.Add(sprite);
        }

        public int ValidateProduct(string code)
        {
            int pos = -1;
            for (int i = 0; i < this.Products.Count; i++)
            {
                if (this.Products[i].Code == code)
                {
                    pos = i;
                }
            }
            return pos;
        }


        public bool AddProduct(CocaColaProduct product)
        {
            int position = this.ValidateProduct(product.Code);
            if (position >= 0)
            {
                this.Products[position].SumQty(product.QTY);
            }
            else
            {
                this.Products.Add(product);
            }
            return true;
        }

        public bool UpdProduct(string code, CocaColaProduct product)
        {
            int position = this.ValidateProduct(code);
            if (position >= 0)
            {
                this.Products[position].Name = product.Name;
                this.Products[position].Category = product.Category;
                this.Products[position].Price = product.Price;
            }
            else
            {
                this.Products.Add(product);
            }
            return true;
        }

        public bool DeleteProduct(string code)
        {
            int position = this.ValidateProduct(code);
            if (position >= 0)
            {
                this.Products.RemoveAt(position);
                return true;
            }

            return false;
        }

        public double ValidateCoins(string[] coins)
        {
            double total = 0;
            foreach (string item in coins)
            {
                try
                {
                    total += float.Parse(item);
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }
            return total;
        }

        //100-50-20-10 money to pay
        public CocaColaProduct Order(string code)
        {
            int pos = this.ValidateProduct(code);
            if (pos > 0)
            {
                if (this.Products[pos].ValidateQTY())
                {
                    string[] coins = this.Payment.Split('-');
                    double total = this.ValidateCoins(coins);
                    if (this.Products[pos].ValidatePrice(total))
                    {
                        this.Products[pos].SubstrProduct();
                        return this.Products[pos];
                    }
                }
            }
            return null;
        }

        public string ListProduct()
        {
            string list = "";
            foreach (CocaColaProduct item in this.Products)
            {
                list += item.Code+" "+item.Name+" "+item.Category+" "+item.QTY+" "+item.Price+"\n";
            }
            return list;
        }
    }
...
```

## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/DanielArturoAlejoAlvarez/Coca-Cola-popular-drink. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [Contributor Covenant](http://contributor-covenant.org) code of conduct.

## License

The gem is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).

```

```
