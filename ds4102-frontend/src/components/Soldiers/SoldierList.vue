<template>
    <section>
        <h2>List of soldiers</h2>
        <soldier-item
            v-for="(soldier, i) in soldiers"
            :key="i"
            :SoldierId="soldier.SoldierId"
            :SoldierName="soldier.SoldierName"
            :Bloodtype="soldier.Bloodtype"
            :Height="soldier.Height"
            :image="soldier.image"
            :IsOnMission="soldier.IsOnMission"
        ></soldier-item>
    </section>
</template>

<script>
import SoldierItem from "./SoldierItem.vue"
import soldierService from "../../services/soldierService.js"

export default {
    setup(){
        const soldiers = soldierService.getAllSoldiers();

        return{
            soldiers
        }
    },
    components: {
        SoldierItem
    }   
}
</script>