import axios from "axios";
import { ref } from 'vue'

const weaponService = (function(){

    const weapons = ref([]);

    const weaponControllerUrl = "https://localhost:7203/weapon";

    ( async ()=>{
        const request = await axios.get(weaponControllerUrl);
        weapons.value = request.data;
    })()

    const getAllWeapons = () => weapons;

    const postWeapon = ( newWeapon ) =>

    weapons.value.push(newWeapon)

    return {
        getAllWeapons,
        postWeapon
    }
}())

export default weaponService;