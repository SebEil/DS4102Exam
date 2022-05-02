<template>
    <section>
        <h2 class="spacingTop">Weapons</h2>
        <article class="row align d-flex justify-content-center">
        <weapon-item
            class="container col p-2 text-center" v-for="(weapon, i) in weapons"
            :key="i"
            :weaponId="weapon.weaponId"
            :weaponName="weapon.weaponName"
            :weaponCost="weapon.weaponCost"
            :inUse="weapon.inUse">
            </weapon-item>
        </article>
    </section>
</template>

<script>
import WeaponItem from "../Weapons/WeaponItem.vue"
import weaponService from "../../services/weaponService.js"

export default {
    setup(){
        const weapons = weaponService.getAllWeapons();

        return{
            weapons
        }
    },
    components: {
        WeaponItem
    }   
}
</script>

<style>

</style>