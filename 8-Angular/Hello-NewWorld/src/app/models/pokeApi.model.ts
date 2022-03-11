import { SpriteApi } from "./spriteApi.model"

export interface PokeApi
{
    id?:number,
    name?:String,
    weight?:number,
    sprites:SpriteApi
    stats?:
    [
        {
            base_stat:number,
            stat:
            {
                name:string

            }
        }

    ]

    

}